using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_174_JA_01 : CardInfo
{
    public CardInfo_174_JA_01()
    {
        this.cardNo = "174_JA_01";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "フック船長";
        this.cardName2 = "強引な決闘者";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = "Marcel Berg";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Challenger2 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
