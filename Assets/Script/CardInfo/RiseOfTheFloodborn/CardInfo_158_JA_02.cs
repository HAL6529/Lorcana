using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_158_JA_02 : CardInfo
{
    public CardInfo_158_JA_02()
    {
        this.cardNo = "158_JA_02";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ƒ‰ƒrƒbƒg";
        this.cardName2 = "‚µ‚Ô‚µ‚Ô‚Ì‚à‚Ä‚È‚µ–ð";
        this.power = 4;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GiuliaRiva;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
