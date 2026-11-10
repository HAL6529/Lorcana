using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_008_JA_04 : CardInfo
{
    public CardInfo_008_JA_04()
    {
        this.cardNo = "008_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ドナルドダック";
        this.cardName2 = "銃士隊の兵士";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JochemVanGool;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Musketeer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
