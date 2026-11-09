using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_009_JA_02 : CardInfo
{
    public CardInfo_009_JA_02()
    {
        this.cardNo = "009_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "‘åŒö";
        this.cardName2 = "‰¤—l‚Ì‘Š’k–ð";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JaviSalas;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
