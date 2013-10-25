// Copyright (c) 2012, Outercurve Foundation.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
//
// - Redistributions of source code must  retain  the  above copyright notice, this
//   list of conditions and the following disclaimer.
//
// - Redistributions in binary form  must  reproduce the  above  copyright  notice,
//   this list of conditions  and  the  following  disclaimer in  the documentation
//   and/or other materials provided with the distribution.
//
// - Neither  the  name  of  the  Outercurve Foundation  nor   the   names  of  its
//   contributors may be used to endorse or  promote  products  derived  from  this
//   software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING,  BUT  NOT  LIMITED TO, THE IMPLIED
// WARRANTIES  OF  MERCHANTABILITY   AND  FITNESS  FOR  A  PARTICULAR  PURPOSE  ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL,  SPECIAL,  EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO,  PROCUREMENT  OF  SUBSTITUTE  GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)  HOWEVER  CAUSED AND ON
// ANY  THEORY  OF  LIABILITY,  WHETHER  IN  CONTRACT,  STRICT  LIABILITY,  OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE)  ARISING  IN  ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.6407
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.3038.
// 

using WebsitePanel.Providers.Common;
using WebsitePanel.Providers.ResultObjects;
using WebsitePanel.Providers.OS;

namespace WebsitePanel.Providers.EnterpriseStorage {
    using System.Xml.Serialization;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Diagnostics;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="EnterpriseStorageSoap", Namespace="http://smbsaas/websitepanel/server/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceProviderItem))]
    public partial class EnterpriseStorage : Microsoft.Web.Services3.WebServicesClientProtocol {
        
        public ServiceProviderSettingsSoapHeader ServiceProviderSettingsSoapHeaderValue;
        
        private System.Threading.SendOrPostCallback GetFoldersOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetFolderOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateFolderOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteFolderOperationCompleted;
        
        private System.Threading.SendOrPostCallback SetFolderQuotaOperationCompleted;
        
        private System.Threading.SendOrPostCallback CheckFileServicesInstallationOperationCompleted;
        
        /// <remarks/>
        public EnterpriseStorage() {
            this.Url = "http://localhost:9003/EnterpriseStorage.asmx";
        }
        
        /// <remarks/>
        public event GetFoldersCompletedEventHandler GetFoldersCompleted;
        
        /// <remarks/>
        public event GetFolderCompletedEventHandler GetFolderCompleted;
        
        /// <remarks/>
        public event CreateFolderCompletedEventHandler CreateFolderCompleted;
        
        /// <remarks/>
        public event DeleteFolderCompletedEventHandler DeleteFolderCompleted;
        
        /// <remarks/>
        public event SetFolderQuotaCompletedEventHandler SetFolderQuotaCompleted;
        
        /// <remarks/>
        public event CheckFileServicesInstallationCompletedEventHandler CheckFileServicesInstallationCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/GetFolders", RequestNamespace="http://smbsaas/websitepanel/server/", ResponseNamespace="http://smbsaas/websitepanel/server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public SystemFile[] GetFolders(string organizationId) {
            object[] results = this.Invoke("GetFolders", new object[] {
                        organizationId});
            return ((SystemFile[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetFolders(string organizationId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetFolders", new object[] {
                        organizationId}, callback, asyncState);
        }
        
        /// <remarks/>
        public SystemFile[] EndGetFolders(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((SystemFile[])(results[0]));
        }
        
        /// <remarks/>
        public void GetFoldersAsync(string organizationId) {
            this.GetFoldersAsync(organizationId, null);
        }
        
        /// <remarks/>
        public void GetFoldersAsync(string organizationId, object userState) {
            if ((this.GetFoldersOperationCompleted == null)) {
                this.GetFoldersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFoldersOperationCompleted);
            }
            this.InvokeAsync("GetFolders", new object[] {
                        organizationId}, this.GetFoldersOperationCompleted, userState);
        }
        
        private void OnGetFoldersOperationCompleted(object arg) {
            if ((this.GetFoldersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFoldersCompleted(this, new GetFoldersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/GetFolder", RequestNamespace="http://smbsaas/websitepanel/server/", ResponseNamespace="http://smbsaas/websitepanel/server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public SystemFile GetFolder(string organizationId, string folder) {
            object[] results = this.Invoke("GetFolder", new object[] {
                        organizationId,
                        folder});
            return ((SystemFile)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetFolder(string organizationId, string folder, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetFolder", new object[] {
                        organizationId,
                        folder}, callback, asyncState);
        }
        
        /// <remarks/>
        public SystemFile EndGetFolder(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((SystemFile)(results[0]));
        }
        
        /// <remarks/>
        public void GetFolderAsync(string organizationId, string folder) {
            this.GetFolderAsync(organizationId, folder, null);
        }
        
        /// <remarks/>
        public void GetFolderAsync(string organizationId, string folder, object userState) {
            if ((this.GetFolderOperationCompleted == null)) {
                this.GetFolderOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFolderOperationCompleted);
            }
            this.InvokeAsync("GetFolder", new object[] {
                        organizationId,
                        folder}, this.GetFolderOperationCompleted, userState);
        }
        
        private void OnGetFolderOperationCompleted(object arg) {
            if ((this.GetFolderCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFolderCompleted(this, new GetFolderCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/CreateFolder", RequestNamespace="http://smbsaas/websitepanel/server/", ResponseNamespace="http://smbsaas/websitepanel/server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CreateFolder(string organizationId, string folder) {
            this.Invoke("CreateFolder", new object[] {
                        organizationId,
                        folder});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginCreateFolder(string organizationId, string folder, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("CreateFolder", new object[] {
                        organizationId,
                        folder}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndCreateFolder(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        public void CreateFolderAsync(string organizationId, string folder) {
            this.CreateFolderAsync(organizationId, folder, null);
        }
        
        /// <remarks/>
        public void CreateFolderAsync(string organizationId, string folder, object userState) {
            if ((this.CreateFolderOperationCompleted == null)) {
                this.CreateFolderOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateFolderOperationCompleted);
            }
            this.InvokeAsync("CreateFolder", new object[] {
                        organizationId,
                        folder}, this.CreateFolderOperationCompleted, userState);
        }
        
        private void OnCreateFolderOperationCompleted(object arg) {
            if ((this.CreateFolderCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateFolderCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/DeleteFolder", RequestNamespace="http://smbsaas/websitepanel/server/", ResponseNamespace="http://smbsaas/websitepanel/server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteFolder(string organizationId, string folder) {
            this.Invoke("DeleteFolder", new object[] {
                        organizationId,
                        folder});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginDeleteFolder(string organizationId, string folder, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("DeleteFolder", new object[] {
                        organizationId,
                        folder}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndDeleteFolder(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        public void DeleteFolderAsync(string organizationId, string folder) {
            this.DeleteFolderAsync(organizationId, folder, null);
        }
        
        /// <remarks/>
        public void DeleteFolderAsync(string organizationId, string folder, object userState) {
            if ((this.DeleteFolderOperationCompleted == null)) {
                this.DeleteFolderOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteFolderOperationCompleted);
            }
            this.InvokeAsync("DeleteFolder", new object[] {
                        organizationId,
                        folder}, this.DeleteFolderOperationCompleted, userState);
        }
        
        private void OnDeleteFolderOperationCompleted(object arg) {
            if ((this.DeleteFolderCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteFolderCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/SetFolderQuota", RequestNamespace="http://smbsaas/websitepanel/server/", ResponseNamespace="http://smbsaas/websitepanel/server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetFolderQuota(string organizationId, string folder, long quota) {
            this.Invoke("SetFolderQuota", new object[] {
                        organizationId,
                        folder,
                        quota});
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSetFolderQuota(string organizationId, string folder, long quota, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SetFolderQuota", new object[] {
                        organizationId,
                        folder,
                        quota}, callback, asyncState);
        }
        
        /// <remarks/>
        public void EndSetFolderQuota(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        public void SetFolderQuotaAsync(string organizationId, string folder, long quota) {
            this.SetFolderQuotaAsync(organizationId, folder, quota, null);
        }
        
        /// <remarks/>
        public void SetFolderQuotaAsync(string organizationId, string folder, long quota, object userState) {
            if ((this.SetFolderQuotaOperationCompleted == null)) {
                this.SetFolderQuotaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetFolderQuotaOperationCompleted);
            }
            this.InvokeAsync("SetFolderQuota", new object[] {
                        organizationId,
                        folder,
                        quota}, this.SetFolderQuotaOperationCompleted, userState);
        }
        
        private void OnSetFolderQuotaOperationCompleted(object arg) {
            if ((this.SetFolderQuotaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetFolderQuotaCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/CheckFileServicesInstallation", RequestNamespace="http://smbsaas/websitepanel/server/", ResponseNamespace="http://smbsaas/websitepanel/server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool CheckFileServicesInstallation() {
            object[] results = this.Invoke("CheckFileServicesInstallation", new object[0]);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginCheckFileServicesInstallation(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("CheckFileServicesInstallation", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndCheckFileServicesInstallation(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void CheckFileServicesInstallationAsync() {
            this.CheckFileServicesInstallationAsync(null);
        }
        
        /// <remarks/>
        public void CheckFileServicesInstallationAsync(object userState) {
            if ((this.CheckFileServicesInstallationOperationCompleted == null)) {
                this.CheckFileServicesInstallationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckFileServicesInstallationOperationCompleted);
            }
            this.InvokeAsync("CheckFileServicesInstallation", new object[0], this.CheckFileServicesInstallationOperationCompleted, userState);
        }
        
        private void OnCheckFileServicesInstallationOperationCompleted(object arg) {
            if ((this.CheckFileServicesInstallationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckFileServicesInstallationCompleted(this, new CheckFileServicesInstallationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void GetFoldersCompletedEventHandler(object sender, GetFoldersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFoldersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFoldersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public SystemFile[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SystemFile[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void GetFolderCompletedEventHandler(object sender, GetFolderCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFolderCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFolderCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public SystemFile Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((SystemFile)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void CreateFolderCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void DeleteFolderCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void SetFolderQuotaCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    public delegate void CheckFileServicesInstallationCompletedEventHandler(object sender, CheckFileServicesInstallationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckFileServicesInstallationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CheckFileServicesInstallationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}