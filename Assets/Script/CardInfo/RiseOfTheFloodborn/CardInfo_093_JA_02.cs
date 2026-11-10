using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_093_JA_02 : CardInfo
{
    public CardInfo_093_JA_02()
    {
        this.cardNo = "093_JA_02";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "èóâ§";
        this.cardName2 = "Ç›ÇπÇ©ÇØÇÃï®îÑÇË";
        this.power = 2;
        this.toughness = 3;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Queen};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
