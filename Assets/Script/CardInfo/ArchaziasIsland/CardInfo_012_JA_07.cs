using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_012_JA_07 : CardInfo
{
    public CardInfo_012_JA_07()
    {
        this.cardNo = "012_JA_07";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ウェンディ・ダーリング";
        this.cardName2 = "海賊女王";
        this.power = 5;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JochemVanGool;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Queen, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
