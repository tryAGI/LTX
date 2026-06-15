#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace LTX \
  --clientClassName LtxClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --exclude-deprecated-operations

rm -rf ../../cli/LTX.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/LTX.CLI \
  --sdk-project ../../libs/LTX/LTX.csproj \
  --targetFramework net10.0 \
  --namespace LTX \
  --clientClassName LtxClient \
  --package-id LTX.CLI \
  --tool-command-name ltx \
  --user-secrets-id LTX.CLI \
  --api-key-env-var LTX_API_KEY \
  --base-url-env-var LTX_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
