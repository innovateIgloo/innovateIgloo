
using System;

namespace OBS.Model
{
    /// <summary>
    /// ��ȡ����Ԫ���ݵ���Ӧ�����
    /// </summary>
    public class GetObjectMetadataResponse : ObsWebServiceResponse
    {

        private MetadataCollection metadataCollection;

        private long _nextPosition = -1;


        /// <summary>
        /// Ͱ����
        /// </summary>
        public string BucketName
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
        /// �����Զ����Ԫ���ݡ�
        /// </summary>
        public MetadataCollection Metadata
        {
            get
            {
                return this.metadataCollection ?? (this.metadataCollection = new MetadataCollection());
            }
            set { this.metadataCollection = value; }
        }

        /// <summary>
        /// �����MIME���͡�
        /// </summary>
        public string ContentType
        {
            get;
            internal set;
        }

        /// <summary>
        /// ����ĳ��ȡ�
        /// </summary>
        public override long ContentLength
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
        /// ����ɾ����ǡ�  
        /// </summary>
        public bool DeleteMarker
        {
            get;
            internal set;
        }


        /// <summary>
        /// �������ϸ������Ϣ��
        /// </summary>
        public ExpirationDetail ExpirationDetail
        {
            get;
            internal set;
        }

        /// <summary>
        /// �鵵�洢���Ͷ����ȡ��״̬���������Ϊ�鵵�洢���ͣ����ֵΪ�ա�
        /// </summary>
        public RestoreStatus RestoreStatus
        {
            get;
            set;
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
        /// �����etagУ��ֵ��
        /// </summary>
        public string ETag
        {
            get;
            internal set;
        }


        /// <summary>
        /// ����汾�š�
        /// </summary>
        public string VersionId
        {
            get;
            internal set;
        }


        /// <summary>
        /// �������ض��򵽸�����ָ����Ͱ�ڵ���һ��������ⲿ��URL��
        /// ��Ͱ������Website���ã��Ϳ������ö���Ԫ���ݵ�������ԡ�
        /// </summary>
        public string WebsiteRedirectLocation
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

        /// <summary>
        /// �´�׷���ϴ���λ��, ����AppendableΪtrue�Ҵ���0ʱ��Ч��
        /// </summary>
        public long NextPosition
        {
            get
            {
                return _nextPosition;
            }
            internal set
            {
                this._nextPosition = value;
            }
        }

    }
}
    
