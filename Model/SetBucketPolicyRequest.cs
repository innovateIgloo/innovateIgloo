

namespace OBS.Model
{
    /// <summary>
    /// ����Ͱ���Ե����������
    /// </summary>
    public class SetBucketPolicyRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "SetBucketPolicy";
        }

        /// <summary>
        /// Ͱ�������ݵ�MD5ֵ�� 
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string ContentMD5 { get; set; }


        /// <summary>
        /// Ͱ�������ݣ� JSON��ʽ���ַ�����
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string Policy { get; set; }

    }
}
    
