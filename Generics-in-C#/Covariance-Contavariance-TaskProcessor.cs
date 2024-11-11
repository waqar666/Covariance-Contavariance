// covariance and contravariance example

//covariance
ITaskTypeGenerator<Task> emailgenerator = new EmailTaskGenerator();
ITaskTypeGenerator<Task> reportgenerator = new ReportTaskGenerator();
//covariance
Task emailtask = emailgenerator.GetTask();
Console.WriteLine($" Email Title is {emailtask.Title}, Recepient is {(emailtask as EmailTask)?.Recepient} ");
Task reporttask = reportgenerator.GetTask();
Console.WriteLine($"Report Title is {reporttask.Title}, Report Type is {(reporttask as ReportTask)?.ReportType}");
//contravariance
ITaskProcessor<EmailTask> emailtaskprocessor = new TaskProcessor();
ITaskProcessor<ReportTask> Reporttaskprocessor = new TaskProcessor();
//contravariance
EmailTask emailtasks = new EmailTask() { Title = "Processing Email task", Recepient = "kelly@kelly.com" };
ReportTask reporttasks = new ReportTask() { Title = "Processing Report task", ReportType = "evening report" };
emailtaskprocessor.ProcessTask(emailtasks);
Reporttaskprocessor.ProcessTask(reporttasks);
public class Task { public string? Title { get; set; } }
public class EmailTask : Task { public string? Recepient { get; set; } }
public class ReportTask : Task { public string? ReportType { get; set; } }
interface ITaskTypeGenerator<out T> where T : Task
{
   T GetTask();
}
public class EmailTaskGenerator : ITaskTypeGenerator<EmailTask>
{
   public EmailTask GetTask()
   {
      return new EmailTask() { Title = "Daily Email", Recepient = "john@johndoe.com" };
   }
}
public class ReportTaskGenerator : ITaskTypeGenerator<ReportTask>
{
   public ReportTask GetTask()
   {
      return new ReportTask() { Title = "Confidential", ReportType = "Morning Report" };
   }
}
interface ITaskProcessor<in T> where T : class
{
   public void ProcessTask(T task);
}
public class TaskProcessor : ITaskProcessor<Task>
{
   public void ProcessTask(Task task)
   {
      Console.WriteLine($"{task.Title}");
   }
}