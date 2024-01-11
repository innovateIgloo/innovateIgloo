
using System.Collections.Generic;

namespace OBS.Model
{
    /// <summary>
    /// �о�Ͱ�ڶ�汾�������Ӧ�����
    /// </summary>
    public class ListVersionsResponse : ObsWebServiceResponse
    {

        private IList<ObsObjectVersion> versions;
        private IList<string> commonPrefixes;

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
        /// �����������ʼλ�ã������������򣩡�
        /// </summary>
        public string KeyMarker
        {
            get;
            internal set;
        }


        /// <summary>
        /// �����������ʼλ�ã�������汾�����򣩡�
        /// </summary>
        public string VersionIdMarker
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
        /// �´��������ʼλ�ã�������汾�����򣩡�
        /// </summary>
        public string NextVersionIdMarker
        {
            get;
            internal set;
        }


        /// <summary>
        /// ��汾�����б�
        /// </summary>
        public IList<ObsObjectVersion> Versions
        {
            get {
               
                return this.versions ?? (this.versions = new List<ObsObjectVersion>()); }
            internal set { this.versions = value; }
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
        /// ��������Ķ�����ǰ׺��
        /// </summary>
        public string Prefix
        {
            get;
            internal set;
        }

        /// <summary>
        /// ��������������Ŀ����
        /// </summary>
        public int? MaxKeys
        {
            get;
            internal set;
        }

        /// <summary>
        /// �����Ķ�����ǰ׺�б�
        /// </summary>
        public IList<string> CommonPrefixes
        {
            get {
                
                return this.commonPrefixes ?? (this.commonPrefixes = new List<string>()); }
            internal set { this.commonPrefixes = value; }
        }

        /// <summary>
        /// ��������Զ��������з�����ַ���
        /// </summary>
        public string Delimiter
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

    }
}
    
