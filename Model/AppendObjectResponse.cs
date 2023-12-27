

namespace OBS.Model
{
    /// <summary>
    /// ׷���ϴ��������Ӧ�����
    /// </summary>
    public class AppendObjectResponse : ObsWebServiceResponse
    {

        private long _nextPosition = -1;

        /// <summary>
        /// ����׷�����ݵ�etagУ��ֵ�� 
        /// </summary>
        public string ETag
        {
            get;
            internal set;
        }

        /// <summary>
        /// �´�׷���ϴ���λ�á�
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

        /// <summary>
        /// ����洢���͡�
        /// </summary>
        public StorageClassEnum? StorageClass
        {
            get;
            internal set;
        }

        /// <summary>
        /// �����ȫ·����
        /// </summary>
        public string ObjectUrl
        {
            get;
            internal set;
        }


    }
}
    
