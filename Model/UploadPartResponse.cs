

namespace OBS.Model
{
    /// <summary>
    /// �ϴ��ε���Ӧ�����
    /// </summary>
    public class UploadPartResponse : ObsWebServiceResponse
    {


        /// <summary>
        /// �ֶε�ETagУ��ֵ��
        /// </summary>
        public string ETag
        {
            get;
            internal set;
        }

        /// <summary>
        /// �ֶκš�
        /// </summary>
        public int PartNumber
        {
            get;
            internal set;
        }


    }
}
    
