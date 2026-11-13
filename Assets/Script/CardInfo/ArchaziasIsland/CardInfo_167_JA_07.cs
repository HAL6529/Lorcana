using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_167_JA_07 : CardInfo
{
    public CardInfo_167_JA_07()
    {
        this.cardNo = "167_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉyÉpÅ[";
        this.cardName2 = "Ç∆Ç¡Ç≥ÇÃÇÌÇÒÇøÇ·ÇÒ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RachelElese;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Puppy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
