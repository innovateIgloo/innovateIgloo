
using OBS.Internal;
using System;
using System.IO;

namespace OBS.Model
{
	/// <summary>
	/// �ϴ����������������
	/// </summary>
    public class UploadStreamRequest : ResumableUploadRequest
    {
        //UplaodStream��ʽ��֧�ֶ��̲߳����ϴ�����taskNum����

        private Stream uploadStream;

        internal override string GetAction()
        {
            return "UploadStream";
        }

        /// <summary>
        /// Ĭ�ϵĹ��캯����
        /// </summary>
        public UploadStreamRequest()
        { }
        /// <summary>
        /// ���캯����
        /// </summary>
        /// <param name="bucketName">Ͱ��</param>
        /// <param name="objectKey">������</param>
        public UploadStreamRequest(string bucketName, string objectKey) :base(bucketName, objectKey)
        {

        }

        /// <summary>
        /// ���캯����
        /// </summary>
        /// <param name="uploadStream">���ϴ���������������ɲ���</param>
        /// <param name="bucketName">Ͱ��</param>
        /// <param name="objectKey">������</param>
        public UploadStreamRequest(Stream uploadStream, string bucketName, string objectKey) 
            : this(bucketName, objectKey)
        {
            this.UploadStream = uploadStream;
        }

        /// <summary>
        /// ���캯����
        /// </summary>
        /// <param name="bucketName">Ͱ��</param>
        /// <param name="objectKey">������</param>
        /// <param name="uploadStream">���ϴ���������������ɲ���</param>
        /// <param name="partSize">��Ƭ��С</param>
        public UploadStreamRequest(string bucketName, string objectKey, Stream uploadStream, long partSize)
            :this(uploadStream, bucketName, objectKey)
        {
            this.UploadPartSize = partSize;
        }

        /// <summary>
        /// ���캯����
        /// </summary>
        /// <param name="bucketName">Ͱ��</param>
        /// <param name="objectKey">������</param>
        /// <param name="uploadStream">���ϴ���������������ɲ���</param>
        /// <param name="partSize">��Ƭ��С</param>
        /// <param name="enableCheckpoint"></param>
        public UploadStreamRequest(string bucketName, string objectKey, Stream uploadStream, long partSize, bool enableCheckpoint)
            : this(bucketName, objectKey, uploadStream, partSize, enableCheckpoint, null)
        {
        }

        /// <summary>
        /// ���캯����
        /// </summary>
        /// <param name="bucketName">Ͱ��</param>
        /// <param name="objectKey">������</param>
        /// <param name="uploadStream">���ϴ���������������ɲ���</param>
        /// <param name="partSize">��Ƭ��С</param>
        /// <param name="enableCheckpoint">�Ƿ����ϵ�����ģʽ</param>
        /// <param name="checkpointFile">�ϵ�����ģʽ�£���¼�ϴ����ȵ��ļ�</param>
        public UploadStreamRequest(string bucketName, string objectKey, Stream uploadStream, long partSize, bool enableCheckpoint, string checkpointFile)
            : this(bucketName, objectKey)
        { 
            this.UploadPartSize = partSize;
            this.UploadStream = uploadStream;
            this.EnableCheckpoint = enableCheckpoint;
            this.CheckpointFile = checkpointFile;
        }

        /// <summary>
        /// ��¼�ϴ����ȵ��ļ���
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��Ĭ��Ϊ��ǰ�������е�Ŀ¼��
        /// </para>
        /// </remarks>
        public override string CheckpointFile
        {
            get;
            set;
        }


        /// <summary>
        /// ���ϴ���������������ɲ��ҡ�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public Stream UploadStream
        {
            get { return this.uploadStream; }
            set { this.uploadStream = value; }
        }


    }
}

