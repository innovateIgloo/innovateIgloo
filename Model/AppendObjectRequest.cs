
using System.Collections.Generic;
using System.IO;

namespace OBS.Model
{
    /// <summary>
    /// ׷���ϴ���������������
    /// </summary>
    public class AppendObjectRequest : PutObjectRequest
    {

        internal override string GetAction()
        {
            return "AppendObject";
        }

        /// <summary>
        /// ׷���ϴ���λ�á�
        /// </summary>
        /// <remarks>
        /// <para>
        /// ������ѡ��
        /// </para>
        /// </remarks>
        public long Position
        {
            get;
            set;
        }

    }
}
    
