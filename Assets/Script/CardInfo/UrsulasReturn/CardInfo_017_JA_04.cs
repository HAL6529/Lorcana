using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_017_JA_04 : CardInfo
{
    public CardInfo_017_JA_04()
    {
        this.cardNo = "017_JA_04";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "É~ÉjÅ[É}ÉEÉX";
        this.cardName2 = "èeémë‡ÇÃóEé“";
        this.power = 1;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Musketeer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
