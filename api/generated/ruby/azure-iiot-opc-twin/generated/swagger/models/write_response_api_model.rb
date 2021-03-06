# encoding: utf-8
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module azure.iiot.opc.twin
  module Models
    #
    # Result of attribute write
    #
    class WriteResponseApiModel
      # @return [Array<AttributeWriteResponseApiModel>] All results of
      # attribute writes
      attr_accessor :results


      #
      # Mapper for WriteResponseApiModel class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          client_side_validation: true,
          required: false,
          serialized_name: 'WriteResponseApiModel',
          type: {
            name: 'Composite',
            class_name: 'WriteResponseApiModel',
            model_properties: {
              results: {
                client_side_validation: true,
                required: false,
                serialized_name: 'results',
                type: {
                  name: 'Sequence',
                  element: {
                      client_side_validation: true,
                      required: false,
                      serialized_name: 'AttributeWriteResponseApiModelElementType',
                      type: {
                        name: 'Composite',
                        class_name: 'AttributeWriteResponseApiModel'
                      }
                  }
                }
              }
            }
          }
        }
      end
    end
  end
end
