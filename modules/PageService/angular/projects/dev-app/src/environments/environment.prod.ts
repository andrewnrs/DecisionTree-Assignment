import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'PageService',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44362/',
    redirectUri: baseUrl,
    clientId: 'PageService_App',
    responseType: 'code',
    scope: 'offline_access PageService',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44362',
      rootNamespace: 'PageService',
    },
    PageService: {
      url: 'https://localhost:44368',
      rootNamespace: 'PageService',
    },
  },
} as Environment;
