using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_014_JA_01 : CardInfo
{
    public CardInfo_014_JA_01()
    {
        this.cardNo = "014_JA_01";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ÉÇÉAÉi";
        this.cardName2 = "ÉÇÉgÉDÉkÉCê∂Ç‹ÇÍ";
        this.power = 1;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = "Nichoras Kole";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
