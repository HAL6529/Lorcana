using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_164_JA_07 : CardInfo
{
    public CardInfo_164_JA_07()
    {
        this.cardNo = "164_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "キーダ";
        this.cardName2 = "創造的発想家";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JenniferParkAndLeonardoGiammichele;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
