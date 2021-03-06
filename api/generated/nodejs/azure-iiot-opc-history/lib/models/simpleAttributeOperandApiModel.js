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
 * Simple attribute operand model
 *
 */
class SimpleAttributeOperandApiModel {
  /**
   * Create a SimpleAttributeOperandApiModel.
   * @property {string} [nodeId] Type definition node id if operand is
   * simple or full attribute operand.
   * @property {array} [browsePath] Browse path of attribute operand
   * @property {string} [attributeId] Possible values include: 'NodeClass',
   * 'BrowseName', 'DisplayName', 'Description', 'WriteMask', 'UserWriteMask',
   * 'IsAbstract', 'Symmetric', 'InverseName', 'ContainsNoLoops',
   * 'EventNotifier', 'Value', 'DataType', 'ValueRank', 'ArrayDimensions',
   * 'AccessLevel', 'UserAccessLevel', 'MinimumSamplingInterval',
   * 'Historizing', 'Executable', 'UserExecutable', 'DataTypeDefinition',
   * 'RolePermissions', 'UserRolePermissions', 'AccessRestrictions'
   * @property {string} [indexRange] Index range of attribute operand
   */
  constructor() {
  }

  /**
   * Defines the metadata of SimpleAttributeOperandApiModel
   *
   * @returns {object} metadata of SimpleAttributeOperandApiModel
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'SimpleAttributeOperandApiModel',
      type: {
        name: 'Composite',
        className: 'SimpleAttributeOperandApiModel',
        modelProperties: {
          nodeId: {
            required: false,
            serializedName: 'nodeId',
            type: {
              name: 'String'
            }
          },
          browsePath: {
            required: false,
            serializedName: 'browsePath',
            type: {
              name: 'Sequence',
              element: {
                  required: false,
                  serializedName: 'StringElementType',
                  type: {
                    name: 'String'
                  }
              }
            }
          },
          attributeId: {
            required: false,
            serializedName: 'attributeId',
            type: {
              name: 'Enum',
              allowedValues: [ 'NodeClass', 'BrowseName', 'DisplayName', 'Description', 'WriteMask', 'UserWriteMask', 'IsAbstract', 'Symmetric', 'InverseName', 'ContainsNoLoops', 'EventNotifier', 'Value', 'DataType', 'ValueRank', 'ArrayDimensions', 'AccessLevel', 'UserAccessLevel', 'MinimumSamplingInterval', 'Historizing', 'Executable', 'UserExecutable', 'DataTypeDefinition', 'RolePermissions', 'UserRolePermissions', 'AccessRestrictions' ]
            }
          },
          indexRange: {
            required: false,
            serializedName: 'indexRange',
            type: {
              name: 'String'
            }
          }
        }
      }
    };
  }
}

module.exports = SimpleAttributeOperandApiModel;
