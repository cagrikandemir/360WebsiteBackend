using _360Backend.BusinessLayer.Abstract;
using _360Backend.DtoLayer.AboutDtos;
using _360Backend.EntityLayer.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _360Backend.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly IAboutUsService _aboutUsService;
        private readonly IMapper _mapper;

        public AboutUsController(IAboutUsService aboutUsService, IMapper mapper)
        {
            _aboutUsService = aboutUsService;
            _mapper = mapper;
        }
        [HttpGet("[action]")]
        public IActionResult GetAllAboutUs()
        {
            return Ok(_mapper.Map<List<Aboutus>>(_aboutUsService.GetAllList()));
        }
        [HttpGet("[action]")]
        public IActionResult GetByIdAboutUs(int Id)
        {
            return Ok(_mapper.Map<Aboutus>(_aboutUsService.GetById(Id)));
        }
        [HttpPost("[action]")]
        public IActionResult AddAboutUs(CreateAboutDto createAboutDto)
        {
            var value = _mapper.Map<Aboutus>(createAboutDto);
            _aboutUsService.Tadd(value);
            return Ok("About Us Eklendi"+ value);
        }
        [HttpDelete("[action]/{Id}")]
        public IActionResult DeleteAboutUs(int Id)
        {
            var value = _aboutUsService.GetById(Id);
            _aboutUsService.TDelete(value);
            return Ok("About Us Silindi"+value);
        }
        [HttpPut("[action]")]
        public IActionResult UpdateAboutUs(UpdateAboutDto updateAboutDto)
        {
            var value = _mapper.Map<Aboutus>(updateAboutDto);
            _aboutUsService.TUpdate(value);
            return Ok("AboutUs Güncellendi" + value);
        }
    }
}
