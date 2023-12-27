
using System.Collections.Generic;

namespace OBS.Model
{
    /// <summary>
    /// ����ɾ���������Ӧ�����
    /// </summary>
    public class DeleteObjectsResponse : ObsWebServiceResponse
    {
        private IList<DeletedObject> deleted;
        private IList<DeleteError> errors;

        /// <summary>
        /// ɾ���ɹ��Ķ����б�
        /// </summary>
        public IList<DeletedObject> DeletedObjects
        {
            get {
               
                return this.deleted ?? (this.deleted = new List<DeletedObject>());
            }
            internal set { this.deleted = value; }
        }

        /// <summary>
        /// ɾ��ʧ�ܵĽ���б�
        /// </summary>
        public IList<DeleteError> DeleteErrors
        {
            get {
               
                return this.errors ?? (this.errors = new List<DeleteError>());
            }
            internal set { this.errors = value; }
        }

    }
}
    
