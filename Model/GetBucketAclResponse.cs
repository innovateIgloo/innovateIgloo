

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ����Ȩ�޵���Ӧ�����
    /// </summary>
    public class GetBucketAclResponse : ObsWebServiceResponse
    {
        /// <summary>
        /// ����Ȩ�û�Ȩ����Ϣ�б�
        /// </summary>
        public AccessControlList AccessControlList { get; internal set; }
    }
}
    
