

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ������Ϣ����Ӧ�����
    /// </summary>
    public class GetBucketStorageInfoResponse : ObsWebServiceResponse
    {

        /// <summary>
        ///  Ͱ�Ŀռ��С��
        /// </summary>
        public long Size
        {
            get;
            internal set;
        }

        /// <summary>
        /// Ͱ�Ķ��������
        /// </summary>
        public long ObjectNumber
        {
            get;
            internal set;
        }
      
    }
}
    
