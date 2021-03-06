﻿using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfService
{
    [ServiceContract]
    public interface IService
    {
        // Send data from client to service
        [OperationContract]
        void SendPackage(byte[] rawData, int numberOfpackages);
        // Use MATLAB scripts to process data and classify ski-turns
        [OperationContract]
        OutputData DetectTurns();
    }
    // Format of data that are send from service to client
    [DataContract]
    public class OutputData
    {
        // filtered gyroscope data
        [DataMember]
        public double[] leftGyroX;
        [DataMember]
        public double[] leftGyroY;
        [DataMember]
        public double[] leftGyroZ;
        [DataMember]
        public double[] rightGyroX;
        [DataMember]
        public double[] rightGyroY;
        [DataMember]
        public double[] rightGyroZ;
        // classified either right or left turns
        [DataMember]
        public double[] responses;
        // total number of turns
        [DataMember]
        public double rightTurns;
        [DataMember]
        public double leftTurns;
    }
}
