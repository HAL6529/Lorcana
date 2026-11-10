using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_183_JA_03 : CardInfo
{
    public CardInfo_183_JA_03()
    {
        this.cardNo = "183_JA_03";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ミニーマウス";
        this.cardName2 = "ファンキーな洞窟探検家";
        this.power = 0;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
