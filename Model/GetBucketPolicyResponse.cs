

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ���Ե���Ӧ�����
    /// </summary>
    public class GetBucketPolicyResponse : ObsWebServiceResponse
    {
        /// <summary>
        /// �������ݣ�JSON��ʽ���ַ�����
        /// </summary>
        public string Policy { get; internal set; }

    }
}
    
