 // ReSharper disable once CheckNamespace

 using System.Collections.Generic;

 namespace OptimaJet.Workflow.RavenDB
{
    public class WorkflowScheme
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Scheme { get; set; }
        public bool CanBeInlined { get; set; }
        public List<string> InlinedSchemes { get; set; }

        public List<string> Tags { get; set; }
    }
}
