

namespace OBS.Model
{
    /// <summary>
    /// ��ʼ���ֶ��ϴ���������������
    /// </summary>
    public class InitiateMultipartUploadRequest : PutObjectBasicRequest
    {
        internal override string GetAction()
        {
            return "InitiateMultipartUpload";
        }

        /// <summary>
        /// ���ɵ����ն���Ĺ���ʱ�䡣
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public int? Expires
        {
            get;
            set;
        }

    }
}
    
