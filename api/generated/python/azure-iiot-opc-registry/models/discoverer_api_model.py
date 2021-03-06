# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 2.3.33.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class DiscovererApiModel(Model):
    """Discoverer registration model.

    :param id: Discoverer id
    :type id: str
    :param site_id: Site of the discoverer
    :type site_id: str
    :param discovery: Possible values include: 'Off', 'Local', 'Network',
     'Fast', 'Scan'
    :type discovery: str or ~azure-iiot-opc-registry.models.DiscoveryMode
    :param discovery_config:
    :type discovery_config:
     ~azure-iiot-opc-registry.models.DiscoveryConfigApiModel
    :param log_level: Possible values include: 'Error', 'Information',
     'Debug', 'Verbose'
    :type log_level: str or ~azure-iiot-opc-registry.models.TraceLogLevel
    :param out_of_sync: Whether the registration is out of sync between
     client (module) and server (service) (default: false).
    :type out_of_sync: bool
    :param connected: Whether discoverer is connected on this registration
    :type connected: bool
    """

    _validation = {
        'id': {'required': True},
    }

    _attribute_map = {
        'id': {'key': 'id', 'type': 'str'},
        'site_id': {'key': 'siteId', 'type': 'str'},
        'discovery': {'key': 'discovery', 'type': 'DiscoveryMode'},
        'discovery_config': {'key': 'discoveryConfig', 'type': 'DiscoveryConfigApiModel'},
        'log_level': {'key': 'logLevel', 'type': 'TraceLogLevel'},
        'out_of_sync': {'key': 'outOfSync', 'type': 'bool'},
        'connected': {'key': 'connected', 'type': 'bool'},
    }

    def __init__(self, id, site_id=None, discovery=None, discovery_config=None, log_level=None, out_of_sync=None, connected=None):
        super(DiscovererApiModel, self).__init__()
        self.id = id
        self.site_id = site_id
        self.discovery = discovery
        self.discovery_config = discovery_config
        self.log_level = log_level
        self.out_of_sync = out_of_sync
        self.connected = connected
