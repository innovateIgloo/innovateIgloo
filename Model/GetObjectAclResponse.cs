

namespace OBS.Model
{
    /// <summary>
    /// ��ȡ�������Ȩ�޵���Ӧ�����
    /// </summary>
    public class GetObjectAclResponse : ObsWebServiceResponse
    {
        /// <summary>
        /// ����Ȩ�û�Ȩ����Ϣ�б�
        /// </summary>
        public AccessControlList AccessControlList { get; internal set; }
    }
}
    
