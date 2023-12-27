
using System.Collections.Generic;

namespace OBS.Model
{
    /// <summary>
    /// �оٷֶ��ϴ��������Ӧ�����
    /// </summary>
    public class ListMultipartUploadsResponse : ObsWebServiceResponse
    {

        private IList<MultipartUpload> multipartUploads;
        private IList<string> commonPrefixes;

        /// <summary>
        /// Ͱ����
        /// </summary>
        public string BucketName
        {
            get;
            internal set;
        }

        /// <summary>
        /// �����������ʼλ�ã������������򣩡�
        /// </summary>
        public string KeyMarker
        {
            get;
            internal set;
        }

        /// <summary>
        /// �����������ʼλ�ã����ֶ��ϴ������ID�����򣩡�
        /// </summary>
        public string UploadIdMarker
        {
            get;
            internal set;
        }


        /// <summary>
        /// �´��������ʼλ�ã������������򣩡�
        /// </summary>
        public string NextKeyMarker
        {
            get;
            internal set;
        }


        /// <summary>
        /// �´��������ʼλ�ã����ֶ��ϴ�����ID�����򣩡� 
        /// </summary>
        public string NextUploadIdMarker
        {
            get;
            internal set;
        }

        /// <summary>
        /// �оٷֶ��ϴ�����������Ŀ���� 
        /// </summary>
        public int? MaxUploads
        {
            get;
            internal set;
        }

        /// <summary>
        /// �ж��оٽ���Ƿ񱻽ضϡ�
        ///  true��ʾ�ضϣ�����û�з���ȫ�������false��ʾδ�ضϣ������Ѿ�������ȫ�������
        /// </summary>
        public bool IsTruncated
        {
            get;
            internal set;
        }

        /// <summary>
        /// �ֶ��ϴ������б�
        /// </summary>
        public IList<MultipartUpload> MultipartUploads
        {
            get 
            {
                

                return this.multipartUploads ?? (this.multipartUploads = new List<MultipartUpload>()); 
            }
            internal set { this.multipartUploads = value; }
        }

        /// <summary>
        /// ��������Ķ�����ǰ׺��
        /// </summary>
        public string Prefix
        {
            get;
            internal set;
        }

        /// <summary>
        /// ��������ķ����ַ���
        /// </summary>
        public string Delimiter
        {
            get;
            internal set;
        }

        /// <summary>
        /// �����Ķ�����ǰ׺�б�
        /// </summary>
        public IList<string> CommonPrefixes
        {
            get
            {
               
                return this.commonPrefixes ?? (this.commonPrefixes = new List<string>());
            }
            internal set { this.commonPrefixes = value; }
        }
    }
}
    
