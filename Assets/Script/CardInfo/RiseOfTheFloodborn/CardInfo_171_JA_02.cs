using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_171_JA_02 : CardInfo
{
    public CardInfo_171_JA_02()
    {
        this.cardNo = "171_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ñÏèb";
        this.cardName2 = "êlåôÇ¢ÇÃê¢éÃÇƒêl";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
