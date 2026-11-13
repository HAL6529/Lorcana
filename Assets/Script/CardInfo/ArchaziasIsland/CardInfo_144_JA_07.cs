using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_144_JA_07 : CardInfo
{
    public CardInfo_144_JA_07()
    {
        this.cardNo = "144_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉTÅ[ÅEÉPÉC";
        this.cardName2 = "ëeñ\Ç»ãRém";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KevinSidharta;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Knight };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
