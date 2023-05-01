#include "oatpp/web/server/api/ApiController.hpp"
#include "oatpp/core/macro/codegen.hpp"
#include "oatpp/core/macro/component.hpp"
#include OATPP_CODEGEN_BEGIN(ApiController)

class MathController : public oatpp::web::server::api::ApiController {

private:
	ResultDto::Wrapper createDto(Float32 a, Float32 b, Float32 result) {
		ResultDto::Wrapper dto = ResultDto::createShared();
		dto->value = result;
		dto->message = "Success!";
		dto->arguments = ArgumentsDto::createShared();
		dto->arguments->a = a;
		dto->arguments->b = b;

		return dto;
	};
public:
	MathController(OATPP_COMPONENT(std::shared_ptr<ObjectMapper>, objectMapper))
		: oatpp::web::server::api::ApiController(objectMapper)
	{
	}
	ENDPOINT_INFO(sum) {
		info->tags = std::list<oatpp::String>{ "Main" };
		info-> summary = "Sum of two numbers";
		std::string header1 = "<h1>Glava 1 </h1>";
		std::string header2 = "<h2>Glava 2 </h2>";
		std::string block1 = "<div>Otdelniy block texta nomer odin</div>";
		std::string block2= "<div>Otdelniy block texta nomer dva</div>";
		std::string header3 = "<h2>Glava 2 </h2>";
		std::string link = "<a href=\"https://pseudocoder.ru/\"Ssilka</a>";
		info->description = header + block1 + block2 + link;
		info->queryParams["a"].description = "First param of sum";
	}

	ENDPOINT("GET", "/math/sum", sum, QUERY(Float32, a, "a"), QUERY(Float32, b, "b")) {
		OATPP_COMPONENT(std::shared_ptr<oatpp::data::mapping::ObjectMapper>, objectMapper);
		auto response = ResponseFactory::createResponse(Status::CODE_200, createDto(a, b, a + b), objectMapper);
		return response;
	}
	ENDPOINT_INFO(substract) {
		info->tags = std::list<oatpp::String>{ "Main" };
	}
	ENDPOINT("GET", "/math/substract", substract, QUERY(Float32, a, "a"), QUERY(Float32, b, "b")) {
		OATPP_COMPONENT(std::shared_ptr<oatpp::data::mapping::ObjectMapper>, objectMapper);
		auto response = ResponseFactory::createResponse(Status::CODE_200, createDto(a, b, a - b), objectMapper);
		return response;
	}
	ENDPOINT_INFO(multiply) {
		info->tags = std::list<oatpp::String>{ "Main" };
	}
	ENDPOINT("GET", "/math/multiply", multiply, QUERY(Float32, a, "a"), QUERY(Float32, b, "b")) {
		OATPP_COMPONENT(std::shared_ptr<oatpp::data::mapping::ObjectMapper>, objectMapper);
		auto response = ResponseFactory::createResponse(Status::CODE_200, createDto(a, b, a * b), objectMapper);
		return response;
	}
	ENDPOINT_INFO(divide) {
		info->tags = std::list<oatpp::String>{ "Main" };
	}
	ENDPOINT("GET", "/math/divide", divide, QUERY(Float32, a, "a"), QUERY(Float32, b, "b")) {
		OATPP_COMPONENT(std::shared_ptr<oatpp::data::mapping::ObjectMapper>, objectMapper);
		auto response = ResponseFactory::createResponse(Status::CODE_200, createDto(a, b, a / b), objectMapper);
		return response;
	}

};