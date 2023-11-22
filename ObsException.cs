
using System;
using System.Net;
using OBS.Model;
using System.Text;

namespace OBS
{
    /// <summary>
    ///  OBS�����쳣��
    /// </summary>
    public class ObsException : ServiceException
    {
        /// <summary>
        /// ���캯����
        /// </summary>
        /// <param name="message">OBS����˴���������</param>
        public ObsException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// ���캯����
        /// </summary>
        /// <param name="message">OBS����˴���������</param>
        /// <param name="innerException">���µ�ǰ�쳣���쳣��</param>
        public ObsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// ���캯����
        /// </summary>
        /// <param name="innerException">���µ�ǰ�쳣���쳣��</param>
        public ObsException(Exception innerException)
            : base(innerException.Message, innerException)
        {
        }

        /// <summary>
        /// ���캯����
        /// </summary>
        /// <param name="message">OBS����˴���������</param>
        /// <param name="errorType">�������͡�</param>
        /// <param name="errorCode">OBS����˴����롣</param>
        public ObsException(string message, ErrorType errorType, string errorCode)
            : base(message, errorType, errorCode)
        {
        }

        /// <summary>
        /// ���캯����
        /// </summary>
        /// <param name="message">OBS����˴���������</param>
        /// <param name="errorType">�������͡�</param>
        /// <param name="errorCode">OBS����˴����롣</param>
        /// <param name="requestId">OBS����˷��ص�����Id��</param>
        public ObsException(string message, ErrorType errorType, string errorCode, string requestId)
            : base(message, errorType, errorCode, requestId)
        {
        }

        /// <summary>
        /// ���캯����
        /// </summary>
        /// <param name="message">OBS����˴���������</param>
        /// <param name="errorType">�������͡�</param>
        /// <param name="errorCode">OBS����˴����롣</param>
        /// <param name="requestId">OBS����˷��ص�����Id��</param>
        /// <param name="statusCode">HTTP״̬�롣</param>
        public ObsException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message, errorType, errorCode, requestId, statusCode)
        {
        }

        /// <summary>
        /// ���캯����
        /// </summary>
        /// <param name="message">OBS����˴���������</param>
        /// <param name="innerException">���µ�ǰ�쳣���쳣��</param>
        /// <param name="errorType">�������͡�</param>
        /// <param name="errorCode">OBS����˴����롣</param>
        /// <param name="requestId">OBS����˷��ص�����Id��</param>
        /// <param name="statusCode">HTTP״̬�롣</param>
        public ObsException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message, innerException, errorType, errorCode, requestId, statusCode)
        {
        }

        /// <summary>
        /// ���캯����
        /// </summary>
        /// <param name="message">OBS����˴���������</param>
        /// <param name="innerException">���µ�ǰ�쳣���쳣��</param>
        /// <param name="errorType">�������͡�</param>
        /// <param name="errorCode">OBS����˴����롣</param>
        /// <param name="requestId">OBS����˷��ص�����Id��</param>
        /// <param name="statusCode">HTTP״̬�롣</param>
        /// <param name="obsId2">��ǡ�</param>
        public ObsException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode, string obsId2)
            : base(message, innerException, errorType, errorCode, requestId, statusCode)
        {
            this.ObsId2 = obsId2;
        }

        /// <summary>
        /// ���캯����
        /// </summary>
        /// <param name="message">������Ϣ��</param>
        /// <param name="errorType">�������͡�</param>
        /// <param name="errorCode">OBS����˴����롣</param>
        /// <param name="errorMessage">OBS����˴���������</param>
        /// <param name="requestId">OBS����˷��ص�����Id��</param>
        /// <param name="statusCode">HTTP״̬�롣</param>
        public ObsException(string message, ErrorType errorType, string errorCode, string errorMessage, string requestId, HttpStatusCode statusCode)
            : base(message, errorType, errorCode, requestId, statusCode)
        {
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// ���캯����
        /// </summary>
        /// <param name="message">������Ϣ��</param>
        /// <param name="innerException">���µ�ǰ�쳣���쳣��</param>
        /// <param name="errorType">�������͡�</param>
        /// <param name="errorCode">OBS����˴����롣</param>
        /// <param name="errorMessage">OBS����˴���������</param>
        /// <param name="requestId">OBS����˷��ص�����Id��</param>
        /// <param name="statusCode">HTTP״̬�롣</param>
        public ObsException(string message, Exception innerException, ErrorType errorType, string errorCode, string errorMessage, string requestId, HttpStatusCode statusCode)
            : base(message, innerException, errorType, errorCode, requestId, statusCode)
        {
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// OBS����˷��ص����ڶ�λ����������ǡ�
        /// </summary>
        [Obsolete]
        public string ObsId2 { get; set; }

        /// <summary>
        /// �����ID��
        /// </summary>
        public string HostId
        {
            get;
            set;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Message)
            .Append(", StatusCode:").Append(Convert.ToInt32(this.StatusCode))
                .Append(", ErrorCode:").Append(this.ErrorCode)
                .Append(", ErrorMessage:").Append(this.ErrorMessage)
                .Append(", RequestId:").Append(this.RequestId)
                .Append(", HostId:").Append(this.HostId);
            return sb.ToString();
        }
    }
}
