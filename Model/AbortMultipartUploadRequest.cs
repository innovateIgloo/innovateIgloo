
namespace OBS.Model
{
    /// <summary>
    /// ȡ���ֶ��ϴ���������������
    /// </summary>
    public class AbortMultipartUploadRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "AbortMultipartUpload";
        }

        /// <summary>
        /// ��������
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string ObjectKey
        {
            get;
            set;
        }

        /// <summary>
        /// �ֶ��ϴ�����ID�š�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string UploadId
        {
            get;
            set;
        }

    }
}
    
