using System;
namespace OBS.Model
{
    /// <summary>
    /// �ֶ��ϴ�����
    /// </summary>
    public class MultipartUpload
    {


        /// <summary>
        /// �ֶ��ϴ�����Ĵ���ʱ�䡣 
        /// </summary>
        public DateTime? Initiated
        {
            get;
            internal set;
        }

        /// <summary>
        /// �ֶ��ϴ�����Ĵ����ߡ�
        /// </summary>
        public Initiator Initiator
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
        /// �ֶ��ϴ�����������ߡ�
        /// </summary>
        public Owner Owner
        {
            get;
            internal set;
        }

        /// <summary>
        /// �ֶ��ϴ��������Ĵ洢���͡�  
        /// </summary>
        public StorageClassEnum? StorageClass
        {
            get;
            internal set;
        }

        /// <summary>
        /// �ֶ��ϴ������ID�š�
        /// </summary>
        public string UploadId
        {
            get;
            internal set;
        }

    }
}
