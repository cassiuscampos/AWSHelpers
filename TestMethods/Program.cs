using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWSHelpers;


namespace TestMethods
{
    class Program
    {
        public const int AmazonSQSMaxMessageSize = 256 * 1024;
        static void Main (string[] args)
        {
            TestCreateSQSQueue();
        }


        static void TestCreateSQSQueue()
        {
            String name                         = "queueTestAWSSQS";
            var regionEndPoint                  = AWSGeneralHelper.GetRegionEndpoint() ;
            String ErrorMessage                 = "Fail";
            int DelaySeconds                    = 900;
            int MaximumMessageSize              = AmazonSQSMaxMessageSize;
            int MessageRetentionPeriod          = 60;
            int ReceiveMessageWaitTimeSeconds   = 20;
            int VisibilityTimeout               = 43200;
            string Policy                       = "";
            bool hasSucceed                     = false;

            hasSucceed = AWSSQSHelper.CreateSQSQueue (name, regionEndPoint,out ErrorMessage, DelaySeconds, MaximumMessageSize, MessageRetentionPeriod,
                                                        ReceiveMessageWaitTimeSeconds, VisibilityTimeout, Policy);

        }
    }
}
