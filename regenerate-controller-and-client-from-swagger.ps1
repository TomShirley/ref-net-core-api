
docker run --rm --add-host localhost:192.168.1.115 -v ${PWD}/templates:/templates -v ${PWD}:/src -w /src local-nswag run ./ef-net-core-ref-app-nswag.json /runtime:NetCore31
