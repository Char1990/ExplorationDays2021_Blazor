using System;

namespace WorkflowVisualisation.Data
{
    public class WorkflowData
    {
        public long PersistenceId { get; set; }
        public Guid InstanceId { get; set; }
        public string WorkflowDefinitionId { get; set; }
        public int Version { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        //public virtual PersistedExecutionPointerCollection ExecutionPointers { get; set; }
        public long? NextExecution { get; set; }
        public string Data { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? CompleteTime { get; set; }
        public WorkflowStatus Status { get; set; }
    }
}
