using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_181_JA_01 : CardInfo
{
    public CardInfo_181_JA_01()
    {
        this.cardNo = "181_JA_01";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ヘラクレス";
        this.cardName2 = "真のヒーロー";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = "Marcel Berg";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
