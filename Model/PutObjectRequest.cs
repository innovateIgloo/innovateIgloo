
using OBS.Internal;
using System;
using System.IO;

namespace OBS.Model
{
    /// <summary>
    /// �ϴ��������������
    /// </summary>
    public class PutObjectRequest : PutObjectBasicRequest
    {

        internal override string GetAction()
        {
            return "PutObject";
        }

        private bool _autoClose = true;

        private double _metric;

        /// <summary>
        /// �ϴ����ȷ�����ʽ��Ĭ��ΪByBytes��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ������������UploadProgressʱ��Ч��
        /// </para>
        /// </remarks>
        public ProgressTypeEnum ProgressType
        {
            get;
            set;
        }

        /// <summary>
        /// �ϴ����ȷ��������Ĭ��Ϊ100KB��1�롣
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ������������UploadProgressʱ��Ч��
        /// </para>
        /// </remarks>
        public double ProgressInterval
        {
            get
            {
                return this._metric <= 0 ? (ProgressType == ProgressTypeEnum.ByBytes ? Constants.DefaultProgressUpdateInterval : 1) : this._metric;
            }
            set
            {
                this._metric = value;
            }
        }

        [Obsolete]
        public double ProgressMetric
        {
            get
            {
                return this.ProgressInterval;
            }
            set
            {
                this.ProgressInterval = value;
            }
        }

        /// <summary>
        /// �ϴ����Ȼص�������
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public EventHandler<TransferStatus> UploadProgress
        {
            get;
            set;
        }

        /// <summary>
        /// �Ƿ��Զ��ر���������Ĭ��Ϊtrue��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ������������InputStreamʱ��Ч��
        /// </para>
        /// </remarks>
        public bool AutoClose
        {
            set
            {
                this._autoClose = value;
            }
            get
            {
                return this._autoClose;
            }
        }

        /// <summary>
        /// ���ϴ�����������
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��������FilePathһ��ʹ�á�
        /// </para>
        /// </remarks>
        public Stream InputStream
        {
            get;
            set;
        }

        /// <summary>
        /// ���ϴ����ļ�·��������ָ��Ϊ�ļ���ȫ·����
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��������InputStreamһ��ʹ�á�
        /// </para>
        /// </remarks>
        public string FilePath
        {
            get;
            set;
        }

        /// <summary>
        /// �ϴ�����ɹ��󣬶���Ĺ���ʱ�䡣
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

        /// <summary>
        /// ���ϴ��������ݾ���base64�����MD5ֵ�����ڷ����У��һ���ԡ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string ContentMd5
        {
            get;
            set;
        }

        /// <summary>
        /// ���ϴ��ļ���ĳһ�ֶε���ʼƫ�ƴ�С��
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��Ĭ��ֵΪ0����λΪ�ֽڡ�
        /// </para>
        /// </remarks>
        public long? Offset
        {
            get;
            set;
        }

        /// <summary>
        /// ���ϴ��������ݵĳ��ȡ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public long? ContentLength
        {
            get;
            set;
        } 

    }
}
    
