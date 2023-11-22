
using System;

namespace OBS.Model
{
    /// <summary>
    /// Ͱ��Ϣ��
    /// </summary>
    public class ObsBucket
    {
        

        /// <summary>
        /// Ͱ�Ĵ���ʱ�䡣
        /// </summary>
        public DateTime? CreationDate
        {
            get;
            internal set;
        }

        /// <summary>
        /// Ͱ����
        /// </summary>
        public string BucketName
        {
            get;
            internal set;
        }

        /// <summary>
        /// Ͱ������λ��
        /// </summary>
        public string Location
        {
            get;
            internal set;
        }

        public override string ToString()
        {
            return "BucketName:" + BucketName + ", CreationDate:" + CreationDate + ", Location:" + Location;
        }

    }
}
