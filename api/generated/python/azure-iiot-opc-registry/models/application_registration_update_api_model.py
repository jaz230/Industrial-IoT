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


class ApplicationRegistrationUpdateApiModel(Model):
    """Application registration update request.

    :param product_uri: Product uri
    :type product_uri: str
    :param application_name: Default name of the server or client.
    :type application_name: str
    :param locale: Locale of default name - defaults to "en"
    :type locale: str
    :param localized_names: Localized names keyed off locale id.
     To remove entry, set value for locale id to null.
    :type localized_names: dict[str, str]
    :param certificate: Application public cert
    :type certificate: bytearray
    :param capabilities: Capabilities of the application
    :type capabilities: list[str]
    :param discovery_urls: Discovery urls of the application
    :type discovery_urls: list[str]
    :param discovery_profile_uri: Discovery profile uri
    :type discovery_profile_uri: str
    :param gateway_server_uri: Gateway server uri
    :type gateway_server_uri: str
    """

    _validation = {
        'capabilities': {'unique': True},
        'discovery_urls': {'unique': True},
    }

    _attribute_map = {
        'product_uri': {'key': 'productUri', 'type': 'str'},
        'application_name': {'key': 'applicationName', 'type': 'str'},
        'locale': {'key': 'locale', 'type': 'str'},
        'localized_names': {'key': 'localizedNames', 'type': '{str}'},
        'certificate': {'key': 'certificate', 'type': 'bytearray'},
        'capabilities': {'key': 'capabilities', 'type': '[str]'},
        'discovery_urls': {'key': 'discoveryUrls', 'type': '[str]'},
        'discovery_profile_uri': {'key': 'discoveryProfileUri', 'type': 'str'},
        'gateway_server_uri': {'key': 'gatewayServerUri', 'type': 'str'},
    }

    def __init__(self, product_uri=None, application_name=None, locale=None, localized_names=None, certificate=None, capabilities=None, discovery_urls=None, discovery_profile_uri=None, gateway_server_uri=None):
        super(ApplicationRegistrationUpdateApiModel, self).__init__()
        self.product_uri = product_uri
        self.application_name = application_name
        self.locale = locale
        self.localized_names = localized_names
        self.certificate = certificate
        self.capabilities = capabilities
        self.discovery_urls = discovery_urls
        self.discovery_profile_uri = discovery_profile_uri
        self.gateway_server_uri = gateway_server_uri