using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_151_JA_03 : CardInfo
{
    public CardInfo_151_JA_03()
    {
        this.cardNo = "151_JA_03";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ママ・オーディ";
        this.cardName2 = "神秘の専門家";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RogieCustodioAndErinShin;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
