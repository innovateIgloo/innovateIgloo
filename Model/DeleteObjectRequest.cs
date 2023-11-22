
using System;

namespace OBS.Model
{
    /// <summary>
    /// ɾ����������������
    /// </summary>
    public class DeleteObjectRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "DeleteObject";
        }

        /// <summary>
        /// ��������
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string ObjectKey
        {
            get;
            set;
        }

        /// <summary>
        /// ��ɾ������İ汾�š�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public string VersionId
        {
            get;
            set;
        }

    }
}
    
