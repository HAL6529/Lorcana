using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_078_JA_12 : CardInfo
{
    public CardInfo_078_JA_12()
    {
        this.cardNo = "078_JA_12";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "マクガフィン卿";
        this.cardName2 = "したたか親父";
        this.power = 6;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.BrianKesinger;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
