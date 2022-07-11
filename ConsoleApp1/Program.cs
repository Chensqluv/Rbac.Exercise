using Quartz;
using Quartz.Impl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //创建调度器
            ISchedulerFactory factory = new StdSchedulerFactory();
            IScheduler scheduler = await factory.GetScheduler();

            //创建JobDetail
            var jobdetail = JobBuilder.Create<MyJob>().WithIdentity("myjob").Build();

            //键值对
            IDictionary<string, object> data = new Dictionary<string, object>();
            data.Add("a", Guid.NewGuid());
            data.Add("b", Guid.NewGuid());

            var jobdata = new JobDataMap(data);

            var job = JobBuilder.Create<MyJob>().SetJobData(jobdata).WithIdentity(new JobKey("每三秒触发")).Build();

            //创建触发器
            var trigger = TriggerBuilder.Create().WithSimpleSchedule(t =>
            {
                t.WithInterval(TimeSpan.FromSeconds(3)).WithRepeatCount(10);
            }).Build();

            //通过调度器调度作业执行
            await scheduler.ScheduleJob(job, trigger);
            await scheduler.Start();

            Console.ReadLine();
        }
    }

    public class MyJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine(context.JobDetail.JobDataMap.Get("a"));
            Console.WriteLine(context.JobDetail.Key.Name);
            Console.WriteLine(DateTime.Now);
        }
    }
}
