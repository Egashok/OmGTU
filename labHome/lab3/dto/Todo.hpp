#ifndef  TodoDto_hpp
#define TodoDto_hpp

#include "oatpp/core/Types.hpp"
#include "oatpp//core/macro//codegen.hpp"
#include OATPP_CODEGEN_BEGIN(DTO)
class TodoDto :public oatpp::DTO {
	DTO_INIT(TodoDto, DTO);
	DTO_FIELD(String, name);
	DTO_FIELD(String, description);
	DTO_FIELD(Int16, priority);
	DTO_FIELD(Int16, userId);
};
#endif // ! TodoDto_hpp
