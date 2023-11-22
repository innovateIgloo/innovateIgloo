
using System;

namespace OBS.Model
{
    /// <summary>
    /// ������Ϣ��
    /// </summary>
    public class ObsObject
    {

        /// <summary>
        /// �����etagУ��ֵ��
        /// </summary>
        public string ETag
        {
            get;
            internal set;
        }

        /// <summary>
        /// ��������
        /// </summary>
        public string ObjectKey
        {
            get;
            internal set;
        }

        /// <summary>
        /// ���������޸�ʱ�䡣
        /// </summary>
        public DateTime? LastModified
        {
            get;
            internal set;
        }

        /// <summary>
        /// ����������ߡ�
        /// </summary>
        public Owner Owner
        {
            get;
            internal set;
        }

        /// <summary>
        /// �����С��
        /// </summary>
        public long Size
        {
            get;
            internal set;
        }

        /// <summary>
        /// ����Ĵ洢���͡�
        /// </summary>
        public StorageClassEnum? StorageClass
        {
            get;
            internal set;
        }

        /// <summary>
        /// �����Ƿ�ɱ�׷��д��
        /// </summary>
        public bool Appendable
        {
            get;
            internal set;
        }

    }
}
