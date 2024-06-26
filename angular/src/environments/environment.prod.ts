import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'CMS',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44380/',
    redirectUri: baseUrl,
    clientId: 'CMS_App',
    responseType: 'code',
    scope: 'offline_access CMS',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44380',
      rootNamespace: 'DecisionTree.CMS',
    },
  },
} as Environment;
