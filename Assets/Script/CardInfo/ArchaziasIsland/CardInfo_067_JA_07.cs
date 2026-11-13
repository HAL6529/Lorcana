using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_067_JA_07 : CardInfo
{
    public CardInfo_067_JA_07()
    {
        this.cardNo = "067_JA_07";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "É}Å[ÉäÉì";
        this.cardName2 = "êÁó¢ä·ÇÃêÊå©èpét";
        this.power = 0;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CamKendell;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
