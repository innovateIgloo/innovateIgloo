
using System;


namespace OBS.Model
{
    /// <summary>
    /// ���ƶε���Ӧ�����
    /// </summary>
    public class CopyPartResponse : ObsWebServiceResponse
    {

        /// <summary>
        /// Ŀ��ε�etagֵ��
        /// </summary>
        public string ETag
        {
            get;
            internal set;
        }

        /// <summary>
        /// Ŀ��ε�����޸�ʱ�䡣
        /// </summary>
        public DateTime? LastModified
        {
            get;
            internal set;
        }

        /// <summary>
        /// Ŀ��εķֶκš�
        /// </summary>
        public int PartNumber
        {
            get;
            internal set;
        }


    }
}
    
