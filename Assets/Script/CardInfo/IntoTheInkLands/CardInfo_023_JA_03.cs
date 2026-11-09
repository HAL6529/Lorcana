using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_023_JA_03 : CardInfo
{
    public CardInfo_023_JA_03()
    {
        this.cardNo = "023_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ウェンディ・ダーリング";
        this.cardName2 = "才能ある船員";
        this.power = 1;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AubreyArcher;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
