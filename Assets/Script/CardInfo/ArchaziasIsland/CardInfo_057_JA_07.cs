using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_057_JA_07 : CardInfo
{
    public CardInfo_057_JA_07()
    {
        this.cardNo = "057_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ãêëÂÉRÉuÉâ";
        this.cardName2 = "ÂáãCòOÇÃëÂé÷";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.NicolaSaviori;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Illusion };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>{ EnumController.KeywordAvility.Vanish };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
