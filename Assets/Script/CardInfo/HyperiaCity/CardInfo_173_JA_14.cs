using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_173_JA_14 : CardInfo
{
    public CardInfo_173_JA_14()
    {
        this.cardNo = "173_JA_14";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "エドガー・バルタザール";
        this.cardName2 = "辛抱強い執事";
        this.power = 4;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MatteoMarzocco;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheAristocats;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
