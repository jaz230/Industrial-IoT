/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

/**
 * Supervisor update request
 *
 */
class SupervisorUpdateApiModel {
  /**
   * Create a SupervisorUpdateApiModel.
   * @property {string} [siteId] Site the supervisor is part of
   * @property {string} [logLevel] Possible values include: 'Error',
   * 'Information', 'Debug', 'Verbose'
   */
  constructor() {
  }

  /**
   * Defines the metadata of SupervisorUpdateApiModel
   *
   * @returns {object} metadata of SupervisorUpdateApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'SupervisorUpdateApiModel',
      type: {
        name: 'Composite',
        className: 'SupervisorUpdateApiModel',
        modelProperties: {
          siteId: {
            required: false,
            serializedName: 'siteId',
            type: {
              name: 'String'
            }
          },
          logLevel: {
            required: false,
            serializedName: 'logLevel',
            type: {
              name: 'Enum',
              allowedValues: [ 'Error', 'Information', 'Debug', 'Verbose' ]
            }
          }
        }
      }
    };
  }
}

module.exports = SupervisorUpdateApiModel;
